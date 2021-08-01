# CSharp_Best_Practices
This source code will give you hands on experience on how to use best practices while coding in C#. Also check read me and other files to understand it better.

Standard of writing code	
	1. Always use camelCase for private variables
	2. PascalCase for methods and properties
	3. Always have summary for variables, properties, methods and classes
	4. Don't use underscores, prefixes or abbreviations for naming  variables, properties, methods and classes
	
Properties
	1. Properties name should always represent what class is, For example if class name is Animal then property name should be AnimalBreed
	
Method
	1. Method name should never be noun, It suppose to be action that its performing
	2. Methods should always be private unless necessary.
	3. Add comments for method parameters.
	4. Use limited number of parameters, If number of parameters exceed 3 then you would be better off with creating a class and add these 3 parameters then pass that class as a parameter.
	5. Order of parameters should be consistent and logical.
	6. Method should only be overloaded when it has same purpose but different executions.
	7. Method Chaining :
	
Class
	1. Class should always have Is-A or Has-A relationship.
	2. Always use PascalCase for naming the classes
	3. Use meaningful names for classes. Name of the class should be real world entity, For example Rikam is reference variable but Human is a class. Human is an entity,
       Rikam is an instance of a human
	4. Class should have well define purpose. Single Responsibility principle. 
	5. Class should be closed for modification but should be open for extension
	6. Do  not add multiple classes in one file. Rule is One class per file
	7. Always use regions inside a class to separate out different categories. Such as properties, methods etc.
	8. Follow this order : 
		i. Private variables
		ii. Properties
		iii. Events (If any)
		iv. Constructor
		v. Methods
		vi. Overridden methods (If any)
		vii. Cleanup objects (If any)
	9. Limit LOC of a class. Follow Single responsibility principle to avoid this.

Static classes (Use for logging service or such services)
	1. Use them sparingly
	2. Use for common utilities

Constructor
	17. Code in Constructor should always be bare minimum, initialization of properties, assigning default values etc.
	18. Do not have heavy service or async calls in a constructor.  Constructors should be limited to initializing objects and not have lots of work like a regular method.

Namespaces
	1. Always remove and sort namespaces. (Right click to " remove and sort namespaces")
	2. Avoid using same name for namespaces and classes. Namespaces with the same name as a class may cause confusion and conflicts.
		i. If namespace is namespace Prestige.Biz.Console then don’t name class as Console. It will create more confusion.
	3. Naming convention : <Company><Technology><Feature>
		i. E.g Microsoft.Media.Design
	4. Follow PascalCase
	5. Avoid using predefined namespaces name. Such as "System" to avoid ambiguity.

Singleton
	1. Only use when you know you need only one instance

Unit tests
	1. Have a practice to write unit tests for every method.
		//Arrange
	            var currentPerson = new Human();
	            var expectedPerson = "Rikam";
	            //Act
	            string result = currentPerson.GetName();
	            //Assert
		Assert.AreEqual(expectedPerson, result);
	
Implementing Using Statements
		○ We know one use of using, which is importing namespaces. Let's explore what are the other areas we can take help of using statement.
		○ We can use using block, it creates and manages the resource then disposes them up when it goes out of the scope.
			○ Its best practice is to use for stream and database connection.
			○ Exception occurs when we try to access same resource which is already held by other object. In following example text file theAgency.txt is held by fs1. so fs2 throws an following exception.
			![image](https://user-images.githubusercontent.com/36474843/127769679-4429444b-b736-42a1-a00b-115024c90511.png)

			
			○ So we need first close the resource so other objects can access. We can achieve this with Using block. It makes sure resource is cleared as soon as it leaves the block.
		![image](https://user-images.githubusercontent.com/36474843/127769684-8e0487ca-c507-4b46-8d86-603b9d38b11b.png)
	




