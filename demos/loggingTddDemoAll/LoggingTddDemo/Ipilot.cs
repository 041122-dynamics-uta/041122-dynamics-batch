using System;

namespace ClassesDemo
{
    public interface Ipilot// interface names conventionally start with 'I'
    {
        int PilotIdNumber { get; set; }
        DateTime DateOfCertification { get; set; }
        string TypeOfPlane { get; set; }

        string Greeting();
        string TimeSinceCertification();// in the implementing class, YOU must create a body of the method.
        void SetDateOfCertification(DateTime d);



    }
}