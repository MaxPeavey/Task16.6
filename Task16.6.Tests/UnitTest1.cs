namespace Task16._6.Tests;


[TestFixture]
public class Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();
        
        [Test]
        public void Additional_MustReturnsCorrectValue()
        {
           Assert.That(_calculator.Additional(7,4), Is.EqualTo(11)); 
        }
        
        [Test]
        public void Additional_MustReturnsCorrectType()
        {
            Assert.That(_calculator.Additional(7, 4).GetType(), Is.EqualTo(typeof(int)));
        }
        
        [Test]
        public void Subtraction_MustReturnsCorrectValue()
        {
            Assert.That(_calculator.Subtraction(7, 4), Is.EqualTo(3));
        }
        
        [Test]
        public void Subtraction_MustReturnsCorrectType()
        {
            Assert.That(_calculator.Subtraction(7, 4).GetType(), Is.EqualTo(typeof(int)));
        }
        
        [Test]
        public void Multiplication_MustReturnsCorrectValue()
        {
            Assert.That(_calculator.Miltiplication(7,7),  Is.EqualTo(49));
        }
        
        [Test]
        public void Multiplication_MustReturnsCorrectType()
        {
            Assert.That(_calculator.Miltiplication(7,7),  Is.EqualTo(49));
        }
        
        [Test]
        public void Division_MustReturnsCorrectValue()
        {
            Assert.That(_calculator.Division(14,7), Is.EqualTo(2));
        }
        
        [Test]
        public void Division_MustReturnsCorrectType()
        {
            Assert.That(_calculator.Division(14,7).GetType(), Is.EqualTo(typeof(int)));
        }
    }
    
}