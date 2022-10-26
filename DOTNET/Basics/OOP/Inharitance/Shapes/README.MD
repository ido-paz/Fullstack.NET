# class , class inharitance Shapes practice
1. Create Shape class has color string field , if the color is empty or null throw error
    a. Add GetDetails method that return the class name , color
2. Create Circle class that extends Shape class.
    a. Add additional radius number field in the constructor, if the radius is not a number throw error
    b. Add GetPerimeter method that return the perimeter // 2 * PI * radius
    c. Override GetDetails method and return the class name , color ,  GetPerimeter value
3. Create Square class that extends Shape class.
    a. Add additional sideA ,sideB number fields in the constructor, if the sideA  is not a number throw error
    b. Add GetPerimeter method that return the perimeter // (sideA + sideB) * 2
    c. Override GetDetails method and return the class name , color ,  GetPerimeter value
4. Create Triangle class that extends Shape class.
    a. Add additional sideA ,sideB,sideC number fields in the constructor, if the sideA ,sideB,sideC is not a number throw error
    b. Add GetPerimeter method that return the perimeter // sideA + sideB + sideC
    c. Override GetDetails method and return the class name , color ,  GetPerimeter value
*use ValidateNumber to throw Exception of a value is 0 or below
*use the existing code 