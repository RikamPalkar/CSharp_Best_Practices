# CSharp_Best_Practices
This source code will give you hands on experience on how to use best practices while coding in C#. Also check read me to understand code snippets better and to learn basic coding standards.

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
	
	7. Method Chaining
	
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

	1. Code in Constructor should always be bare minimum, initialization of properties, assigning default values etc.
	
	2. Do not have heavy service or async calls in a constructor.  Constructors should be limited to initializing objects and not have lots of work like a regular method.

Namespaces

	1. Always remove and sort namespaces. (Right click to " remove and sort namespaces")
	
	2. Avoid using same name for namespaces and classes. Namespaces with the same name as a class may cause confusion and conflicts.
	
		i. If namespace is namespace Prestige.Biz.Console then don’t name class as Console. It will create more confusion.
		
	3. Naming convention : <Company><Technology><Feature>
		i. E.g Microsoft.Media.Design
		
	4. Follow PascalCase
	
	5. Avoid using predefined namespaces name. Such as "System" to avoid ambiguity.

	
Implementing Using Statements

	1. We know one use of using, which is importing namespaces. Let's explore what are the other areas we can take help of using statement.
	2. We can use using block, it creates and manages the resource then disposes them up when it goes out of the scope.
	 ○ Its best practice is to use for stream and database connection.
	 ○ Exception occurs when we try to access same resource which is already held by other object. In following example text file theAgency.txt is held by fs1. so fs2 throws an following exception. 
![image](https://user-images.githubusercontent.com/36474843/127769943-4b637e15-e382-4d93-a1bd-77096d7679db.png)

	 ○ So we need first close the resource so other objects can access. We can achieve this with Using block. It makes sure resource is cleared as soon as it leaves the block.
![image](https://user-images.githubusercontent.com/36474843/127769975-b8d0522f-cc10-49e9-9ee3-8ff46ae54e7c.png)
	

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


Constant variables

	1. Compile-time constant	
	2. Assigned on declaration	
	3. Only number, Boolean or string	
	4. Always static
	
Read-Only variables
	
	1. Runtime constant
	2. Assigned on declaration or constructor
	3. Any data type
	4. Optionally static

	
	Do's
	1. Define meaningful names	Do not use uppercase/ abbreviations
	2. Use PascalCase	
	3. Use constants for compile-time	
	4. Use constants for run-time
	
	Don'ts
	1. Do not use uppercase/ abbreviations

Properties 

	provide flexible mechanism to do the following to private fields:
		○ Read
		○ Write
		○ Compute it value
		○ Accessors : Getters and Setters
		○ Getters used for following 2 things :
		○ Lazy loading -> It checks if Actor exist or not, if yes then it returns the same actor. Creates an object only if needed else it creates a new Actor.
![image](https://user-images.githubusercontent.com/36474843/127770182-ad12acbf-04b6-4b80-b695-5595ccb2a6f1.png)

		○ Validating incoming value -> Checking length of a name before assigning the value
![image](https://user-images.githubusercontent.com/36474843/127770209-736bdd24-fbb2-4b09-8534-2a8e426b6757.png)

	Do's
	1. Use relevant names
	2. Use getters for simple protection, formatting and initializing
	3. Use setters for simple protection, formatting and validation

	Don't
	1. Do not use abbreviations
	2. Avoid using complex logic in getters and setters
	
Auto implemented properties

![image](https://user-images.githubusercontent.com/36474843/127770507-99ac2a49-be54-46c6-945b-e1540ba83529.png)

	Do's
	1. Use relevant names
	2. Initialize the property when needed

	Don't
	1. Do not use abbreviations

Managing objects efficiently.

	i. Initializing objects
	○ Parameterized  constructors
		□ Good when creating basic set of properties
![image](https://user-images.githubusercontent.com/36474843/127770545-886f5ad7-fd97-4423-ba88-3518ac267c93.png)

	○ Object Initializers
		□ Good when initializing a subset or superset of properties
		□ Good for readability
![image](https://user-images.githubusercontent.com/36474843/127770559-ab3380fb-792f-4fe2-b95a-238d9c841d80.png)

	○ Setting properties as an object
		□ Good for populating from databases
		□ Good for modifying properties
![image](https://user-images.githubusercontent.com/36474843/127770575-7740107b-28b4-4746-b19d-f33f49d30522.png)

	ii. Use Lazy loading for initializing objects.
	iii. If Objects are needed only one time, consider instantiating an object within a method
![image](https://user-images.githubusercontent.com/36474843/127770592-82fa5c51-e7c5-4a9e-95d3-97d1266fd83a.png)

	iv. If Object is needed always, consider creating a property and initialize it in a default constructor
![image](https://user-images.githubusercontent.com/36474843/127770650-885c0f77-13aa-4e55-9eca-ecb0bfcea6f5.png)

	v. If Object is needed sometime, User getter to lazy load.
![image](https://user-images.githubusercontent.com/36474843/127770661-7be737b1-8f57-48ff-bbcd-3f8301ef92ff.png)

	vi. Always checking for null
![image](https://user-images.githubusercontent.com/36474843/127770671-85f50930-930e-4b08-a93c-9f8c39db1ec9.png)



