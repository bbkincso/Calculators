import unittest
from myCalculator import MyCalculator

class myCalculatorTest(unittest.TestCase):
    
    def test_addTwoNumbers(self):
        my_calc = MyCalculator()
        self.assertEqual(0, my_calc.addTwoNumbers(0, 0))
        self.assertEqual(0, my_calc.addTwoNumbers(-3, 3))
        self.assertEqual(0, my_calc.addTwoNumbers(3, -3))
        self.assertEqual(-1, my_calc.addTwoNumbers(2, -3))
        self.assertEqual(5, my_calc.addTwoNumbers(2, 3))
        self.assertEqual(-3, my_calc.addTwoNumbers(0, -3))
        
    def test_subtractTwoNumbers(self):
        my_calc = MyCalculator()
        self.assertEqual(0, my_calc.subtractTwoNumbers(2, 2))
        self.assertEqual(0, my_calc.subtractTwoNumbers(-2, -2))
        self.assertEqual(3, my_calc.subtractTwoNumbers(1, -2))
        self.assertEqual(5, my_calc.subtractTwoNumbers(7, 2))
        self.assertEqual(0, my_calc.subtractTwoNumbers(0, 0))
        
    def test_multipleTwoNumbers(self):
         my_calc = MyCalculator()
         self.assertEqual(0, my_calc.multipleTwoNumbers(0,0))
         self.assertEqual(0, my_calc.multipleTwoNumbers(0,5))
         self.assertEqual(0, my_calc.multipleTwoNumbers(2,0))
         self.assertEqual(25, my_calc.multipleTwoNumbers(5,5))
         self.assertEqual(4, my_calc.multipleTwoNumbers(-2,-2))
         self.assertEqual(0.5, my_calc.multipleTwoNumbers(0.5,1))
         
         
    def test_division(self):
        my_calc = MyCalculator()
        self.assertEqual(2.5, my_calc.division(5,2))
        self.assertEqual(4, my_calc.division(2,0.5))
        self.assertEqual(2.5, my_calc.division(5,2))
        self.assertEqual(-2.5, my_calc.division(-5,2))
        self.assertEqual(2, my_calc.division(-6,-3))
        
    def test_factorial(self):
        my_calc = MyCalculator()
        self.assertEqual(24, my_calc.factorial(4))
        self.assertEqual(120, my_calc.factorial(5))
    
    def test_combination(self):
        my_calc = MyCalculator()
        self.assertEqual(252, my_calc.combination(10,5))
        self.assertEqual(1, my_calc.combination(10,0))
        self.assertEqual(1, my_calc.combination(0,0))
        
    def test_permutation(self):
        my_calc = MyCalculator()
        self.assertEqual(30240, my_calc.permutation(10,5))
        self.assertEqual(1, my_calc.permutation(10,0))
        self.assertEqual(1, my_calc.permutation(0,0))
        self.assertEqual(90, my_calc.permutation(10,2))
        
    def test_square(self):
        my_calc = MyCalculator()
        self.assertEqual(0, my_calc.square(0))
        self.assertEqual(4, my_calc.square(2))
        self.assertEqual(4, my_calc.square(-2))
        self.assertEqual(25, my_calc.square(5))
        
    def test_squareRoot(self):
        my_calc = MyCalculator()
        self.assertEqual(0, my_calc.squareRoot(0))
        self.assertEqual(1, my_calc.squareRoot(1))
        self.assertEqual(5, my_calc.squareRoot(25))
        self.assertEqual(2.5, my_calc.squareRoot(6.25))
        
    def test_cube(self):
        my_calc = MyCalculator()
        self.assertEqual(0, my_calc.cube(0))
        self.assertEqual(1, my_calc.cube(1))
        self.assertEqual(-1, my_calc.cube(-1))
        self.assertEqual(27, my_calc.cube(3))
        self.assertEqual(3.375, my_calc.cube(1.5))
        
    def test_cubeRoot(self):
        my_calc = MyCalculator()
        self.assertEqual(0, my_calc.cubeRoot(0))
        self.assertEqual(1, my_calc.cubeRoot(1))
        self.assertEqual(3, my_calc.cubeRoot(27))
        self.assertEqual(1.5, my_calc.cubeRoot(3.375))
        
    def test_exponentiate(self):
        my_calc = MyCalculator()
        self.assertEqual(0, my_calc.exponentiate(0,10))
        self.assertEqual(1, my_calc.exponentiate(1,0))
        self.assertEqual(1, my_calc.exponentiate(1,2))
        self.assertEqual(1, my_calc.exponentiate(-1,2))
        self.assertEqual(-1, my_calc.exponentiate(-1,3))
        self.assertEqual(625, my_calc.exponentiate(5,4))
        self.assertEqual(2187, my_calc.exponentiate(3,7))
        
    
    
unittest.main()

