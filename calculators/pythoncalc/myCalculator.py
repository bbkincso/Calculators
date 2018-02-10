class MyCalculator:
    
    def addTwoNumbers(self, num1, num2):
         """Returns the sum of two numbers."""
         result = float(num1) + float(num2)
         return result
    
    def subtractTwoNumbers(self, num1, num2):
        """Returns the difference of two numbers."""
        result = float(num1) - float(num2)
        return result
    
    def multipleTwoNumbers(self, num1, num2):
        """Returns the product of two numbers."""
        result = float (num1) * float (num2)
        return result
    
    def division(self, num1, num2):
        """Returns the quotient of two numbers."""
        result = float (num1) / float (num2)
        return result
    
    def factorial(self, num):
        """Returns the factorial of a number."""       
        count = 1
        result = 1
        
        while count <= num:
            result *=count
            count += 1
            
        return result
    
    def combination(self, num1, num2):
        """Returns the combination of given numbers of objets at a given time."""
        n = float (num1)
        r = float (num2)
        temporary = self.factorial(n-r)*self.factorial(r)
        result = self.factorial(n)/temporary
        return result
    
    def permutation(self, num1, num2):
        """Returns the permutation of given numbers of objets at a given time."""
        n = float (num1)
        r = float (num2)
        result = self.factorial(n) / self.factorial(n-r)
        return result
    
    def square(self, num):
        """Returns the square of a number."""
        result = float (num) ** 2
        return result 
    
    def squareRoot(self, num):
        """Returns the square root of a number."""
        num = float (num)
        from math import sqrt
        result = sqrt(num)
        return result 
    
    def cube(self, num):
        """Returns the cube of a number."""
        result = float (num) ** 3
        return result 
    
    def cubeRoot(self, num):
        """Returns the cube root of a number."""
        result = float (num) ** (1. / 3)
        return result 
    
    def exponentiate(self, base, exponent):
        """Returns the exponentiate of a given base and given exonent."""
        result = float (base) ** float (exponent)
        return result
        
    
    def count(self, user_input):
        """Displays menu and asks user to choose operation,
           asks for parameters, 
           prints the result of the chosen operation with the parameters """        
        while True:
            print("Welcome to easy calculator:")
            print("Please enter a number to select operation!")
            print("Addition => 1")
            print("Subtraction => 2")
            print("Multiplication => 3")
            print("Division => 4")
            print("Combination/Permutation => 5")
            print("Square => 6")
            print("Square root => 7")
            print("Cube => 8")
            print("Cube root => 9")
            print("Exponentiate => 10")
            print("Exit => 999")
            user_input = input(": ")
            
            try:
                if user_input == "1":
                   num1 = input("enter num1: ")
                   num2 = input("enter num2: ")         
                   print ("The result is: %s" %self.addTwoNumbers(num1,num2)) 
                  
               
                elif user_input == "2":
                    num1 = input("enter num1: ")
                    num2 = input("enter num2: ")
                    print (self.substractTwoNumbers(num1,num2))
                    
                elif user_input == "3":
                    num1 = input("enter num1: ")
                    num2 = input("enter num2: ")
                    print (self.multipleTwoNumbers(num1,num2))
                
                elif user_input == "4":
                    num1 = input("enter num1: ")
                    num2 = input("enter num2: ")
                    print (self.division(num1,num2))
                    
                elif user_input == "5":
                    num1 = input("enter num1: ")
                    num2 = input("enter num2: ")
                    print ("combination: %s and permutation: %s" %(self.combination(num1,num2), self.permutation(num1,num2)))
                    
                    
                elif user_input == "6":
                    num1 = input("enter num1: ")
                    print (self.square(num1))
                    
                elif user_input == "7":
                    num1 = input("enter num1: ")
                    print (self.squareRoot(num1))
                    
                elif user_input == "8":
                    num1 = input("enter num1: ")
                    print (self.cube(num1))
                
                elif user_input == "9":
                    num1 = input("enter num1: ")
                    print (self.cubeRoot(num1))
                    
                elif user_input == "10":
                    num1 = input("enter num1: ")
                    num2 = input("enter num2: ")
                    print (self.exponentiate(num1,num2))
                elif user_input == "999":
                    break
                else:
                    print("Invalid input")
                
            except:
                print("Invalid input")
    
    