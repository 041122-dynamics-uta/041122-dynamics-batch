namespace ClassesDemo
{
    public interface Ipilot// interface names conventionally start with 'I'
    {
        public int PilotIdNumber { get; set; }
        public DateTime DateOfCertification { get; set; }
        public string TypeOfPlane { get; set; }

        public string Greeting();
        public string TimeSinceCertification();// in the implementing class, YOU must create a body of the method.
        public void SetDateOfCertification(DateTime d);



    }
}