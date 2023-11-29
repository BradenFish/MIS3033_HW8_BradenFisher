namespace MIS3033_HW8_BradenFisher.Models
{
    public class Patient
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public double BMI { get; set; }
        public string BMILevel { get; set; }

        public Patient() { }

        public Patient(string id, string name, int age, double weight, double BMI)
        {
            this.ID = id;
            this.Name = name;
            this.age = age;
            this.weight = weight;
            this.BMI = BMI;
        }

        public string GetBMILevel()
        {
            if (BMI < 18.5)
            {
                BMILevel = "Underweight";
            }
            else if (BMI < 25)
            {
                BMILevel = "Healthy Weight";
            }
            else if (BMI < 30)
            {
                BMILevel = "Overweight";
            }
            else
            {
                BMILevel = "Obesity";
            }
            return BMILevel;
        }
    }
}
