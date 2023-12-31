﻿using Microsoft.AspNetCore.Mvc;
using MIS3033_HW8_BradenFisher.Data;
using MIS3033_HW8_BradenFisher.Models;
using System.Runtime.CompilerServices;

namespace MIS3033_HW8_BradenFisher.Controllers
{
    public class HomeController : Controller
    {
        PatientDB db = new PatientDB();

        public JsonResult GetPatients()
        {
            return Json(db.Patients);
        }

        public JsonResult GetChartData() 
        {
            var r = db.Patients.GroupBy(x => x.BMILevel).Select(x => new {level = x.Key, n = x.Count()});
            return Json(r);
        }

        public JsonResult DeletePatient(string id)
        {
            Message mes = new Message();
            Patient patient = db.Patients.Where(x => x.ID == id).FirstOrDefault();

            if (patient == null)
            {
                mes.status = "failed";
                mes.message = $"Patient ID {id} not in the database";
                return Json(mes);
            }
            
            db.Patients.Remove(patient); 
            db.SaveChanges();

            mes.status = "success";
            mes.message = "Patient deleted successfully";
            return Json(mes);
        }

        public JsonResult EditPatient(string id, string name, int age, double weight, double BMI)
        {
            Message mes = new Message();
            Patient patient = db.Patients.Where(x => x.ID == id).FirstOrDefault();

            if (patient == null)
            {
                mes.status = "failed";
                mes.message = $"Patient ID {id} not in the database";
                return Json(mes);
            }

            patient.Name = name;
            patient.age = age;
            patient.weight = weight;
            patient.BMI = BMI;

            patient.GetBMILevel();

            //db.Patients.Add(patient); when edit, do not add to the database, only update
            db.SaveChanges();

            mes.status = "success";
            mes.message = "Patient edited successfully";
            return Json(mes);
        }
        public JsonResult AddPatient(string id, string name, int age, double weight, double BMI)
        {
            Message mes = new Message();
            Patient patient = new Patient();

            patient.ID = id;
            patient.Name = name;
            patient.age = age;
            patient.weight = weight;
            patient.BMI = BMI;

            patient.GetBMILevel();

            db.Patients.Add(patient);
            db.SaveChanges();

            mes.status = "success";
            mes.message = "New patient added successfully";
            return Json(mes);
        }

        public IActionResult Chart() 
        { 
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
