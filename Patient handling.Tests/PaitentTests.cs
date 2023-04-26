using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_handling;
using Patient_Handling;

namespace Patient_Handling.Tests
{
    public class PaitentTests
    {
        [TestClass]
        public class PatientTests
        {
            /*[TestMethod]
            public void TestValidPesel()
            {
                string pesel = "44051401359";
                DateTime birth = new DateTime(1944, 5, 14);
                string sex = "M";

                bool isValid = Patient_Handling.Form_add_patient.IsValidPesel(pesel, birth, sex);

                Assert.IsTrue(isValid);
            }*/

            [TestMethod]
            public void TestIfPeselIsInvalid()
            {
                DateTime birth = new DateTime(1980, 1, 1);
                bool result = Form_add_patient.IsValidPesel("12345678901", birth, "M");
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void TestIfPeselIsValid()
            {
                DateTime birth = new DateTime(1980, 1, 1);
                bool result = Form_add_patient.IsValidPesel("80010112340", birth, "K");
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void TestIfPeselHasWrongSex()
            {
                DateTime birth = new DateTime(1980, 1, 1);
                bool result = Form_add_patient.IsValidPesel("80010112345", birth, "X");
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void TestIfPeselHasWrongBirthDate()
            {
                DateTime birth = new DateTime(2023, 4, 26);
                bool result = Form_add_patient.IsValidPesel("80010112345", birth, "M");
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void TestIfPeselHasInvalidMonth()
            {
                DateTime birth = new DateTime(1980, 2, 1);
                bool result = Form_add_patient.IsValidPesel("80020112345", birth, "M");
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void TestIfPeselHasInvalidDay()
            {
                DateTime birth = new DateTime(1980, 1, 2);
                bool result = Form_add_patient.IsValidPesel("80010112345", birth, "M");
                Assert.IsFalse(result);
            }
        }
    }
}
