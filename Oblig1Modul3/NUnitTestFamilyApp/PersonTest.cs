using NUnit.Framework;
using Oblig1Modul3;

namespace NUnitTestFamilyApp
{
    public class PersonTest
    {

        [Test]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) F�dt: 2000 D�d: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestNoFields()
        {
            var pp = new Person
            {
                Id = 1,
            };
            var actualDescription = pp.GetDescription();
            var expectedDescription = "(Id=1)";
            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestIdAndNameFields()
        {
            var p = new Person
            {
                Id = 5,
                FirstName = "Ola",
                LastName = "Nordmann",
            };
            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=5)";
            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}