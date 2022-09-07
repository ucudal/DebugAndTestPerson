using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void Test1() // Cambiá el nombre para indicar qué estás probando
        {
            //Configuración
            const string expectedId = "12765672";
            const string expectedName = "Tester Name";
            //Ejecución
            Person person = new Person (expectedName, expectedId);
            //Comprobación
            Assert.AreEqual(expectedId, person.ID);
            Assert.AreEqual(expectedName, person.Name);
        }
    }
}