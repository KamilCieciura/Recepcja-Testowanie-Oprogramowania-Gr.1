using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Handling;

namespace Patient_Handling.Tests
{
    internal class PaitentTests
    {
        [TestClass]
        public class PatientTests
        {
            [TestMethod]
            public void TestValidPesel()
            {
                string pesel = "44051401359";
                DateTime birth = new DateTime(1944, 5, 14);
                string sex = "M";

                bool isValid = Patient_Handling.Form_add_patient.IsValidPesel(pesel, birth, sex);

                Assert.IsTrue(isValid);
            }

        }
    }
}
