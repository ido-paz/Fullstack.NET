# Class , class inharitance , shapes practice
1. Create Shape class has color string field , if the color is empty or null throw error
    a. Add GetDetails method that return the class name , color. <br/>
2. Create Circle class that extends Shape class.
    a. Add additional radius number field in the constructor, if the radius is not a number throw error.  <br/>
    b. Add GetPerimeter method that return the perimeter // 2 * PI * radius. <br/>
    c. Override GetDetails method and return the class name , color ,  GetPerimeter value.  <br/>
3. Create Square class that extends Shape class.
    a. Add additional sideA ,sideB number fields in the constructor, if the sideA  is not a number throw error <br/>
    b. Add GetPerimeter method that return the perimeter // (sideA + sideB) * 2 <br/>
    c. Override GetDetails method and return the class name , color ,  GetPerimeter value. <br/>
4. Create Triangle class that extends Shape class.
    a. Add additional sideA ,sideB,sideC number fields in the constructor, if the sideA ,sideB,sideC is not a number throw error. <br/>
    b. Add GetPerimeter method that return the perimeter // sideA + sideB + sideC.  <br/>
    c. Override GetDetails method and return the class name , color ,  GetPerimeter value. <br/>
* use ValidateNumber to throw Exception of a value is 0 or below
* Do not repeat yourself (DRY)