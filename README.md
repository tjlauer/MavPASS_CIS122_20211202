# MavPASS_CIS122_20211202
This programming task is taken from `Test 3` given at `MNSU, Mankato` to `CIS 122` on `December 01, 2021`.

<br><hr>

## Part 1 (20 minutes)
### Part 1.1
Create a `Pet` class with the following characteristics:
- Each `Pet` available has a `species` (only “cat” or “dog” are allowed), `name`,  `petId`, `breed`, and an `age`.
- The only values for `age` allowed are: `“baby”`, `“young”`, `“adult”` or `“mature”`.
<br>

### Part 1.2
Creat an Animal `Shelter` class with the following characteristics:
- Each `Shelter` has a `List` of `Pet` containing a bunch of cats and dogs available for adoption.
- There should be a method `AddToShelter()` which adds a `Pet` to the `List` of `Pet` for the `Shelter`.
- There should be a method `SearchBySpecies()` which returns a `List` of `Pet` of the appropriate species (i.e. `“dog”` or `“cat”`).
- There should be a method `SearchByAge()` which returns a `List` of `Pet` of the appropriate age (i.e. `“baby”`, `“young”`, `“adult”`, or `“mature”`).
- There should be a method `SearchByBreed()` which returns a `List` of `Pet` of the appropriate species (i.e. `“Corgi”` or `“Retriever”`).
<br>

### Part 1.3
In `Main`...
- Create a `Shelter`
- Create 10 `Pet` objects (5 `“dog”` and 5 `“cat”`)
- Show that the `SearchBySpecies()` method works by searching for `“dog”`
- Show that the `SearchByAge()` method works by searching for `“young”`
- Show that the `SearchByBreed()` method works by searching for `“Corgi”`
- Use `ToString()` and a foreach loop to print out:
- A) All the `Pet` objects in the `Shelter`
- B) Only `“cat”` `Pet` objects
- C) Only `“young”` `Pet` objects
- D) Only `“Corgi”` `Pet` objects

<br><hr>

## Part 2 (15 minutes)
### Part 2.1
Add the following to the `Shelter` class...
- Allow the user to search by `species` and `age` (i.e. `SearchForPet(“dog”, “mature”)`).
- Allow the user to search by `species`, `age`, and `breed` (i.e. `SearchForPet(“dog”, “mature”, “Corgi”)`).
- Add a method to `Shelter`, `GetPetById()` that returns a single `Pet` based on a `PetId`.
<br>

### Part 2.2
Creat a `Customer` class with the following characteristics:
- A `Customer` has a `customerID`, `firstName`, `lastName`, and `email`.
- A `Customer` can have multiple `Pet` objects.
- Create a method `Adopt()`, that allows a `Customer` to add a new `Pet` to its `List` of `Pet`.
<br>

### Part 2.3
In `Main`...
- Create a `Customer`
- Get a `Pet` by `PetId`
- Have the `Customer` adopt that `Pet`
- Print out all of the `Customer` information, including any `Pet` objects using `ToString()`.
- Use `ToString()` and a foreach loop to print out:
- A) Only `“baby”` `“dog”` objects.
- B) Only `“baby”` `“dog”` `“Corgi”` objects.

<br><hr>

## Part 3 (15 minutes)
### Part 3.1
- In the `Set` for a `Pet` `species`, if any value except for: `“cat”` or `“dog”` is input – throw a `WrongSpeciesException`. That is, create a new class of `Exception` called `WrongSpeciesException`, which inherits from `Exception`.
- The `message` for this exception should be: `“Only values of: “cat” and “dog” are allowed.”`

Do ***NOT*** catch the `WrongSpeciesException`, just allow the program to crash.

<br>

### Part 3.2
- In the `Set` for a `Pet` `age`, if any value except for: `“baby”`, `“young”`, `“adult”`, or `“mature”` is input – throw a `WrongAgeException`. That is, create a new class of `Exception` called `WrongAgeException`, which inherits from `Exception`.
- The `message` for this exception should be: `“Only values of: “baby”, “young”, “adult”, or “mature” are allowed.”`

Do ***NOT*** catch the `WrongAgeException`, just allow the program to crash.

<br>

### Part 3.3
When `species` == `dog`:
- In the `Set` for a `Pet` `breed`, if any value except for: `“Corgi”`, `“Retriever”`, or `“Border Collie”` is input – throw a `WrongBreedException`. That is, create a new class of `Exception` called `WrongBreedException`, which inherits from `Exception`.
- The `message` for this exception should be: `“Only values of: “Corgi”, “Retriever”, and “Border Collie” are allowed for the specified species.”`

When `species` == `cat`:
- In the `Set` for a `Pet` `breed`, if any value except for: `“Long Hair”` or `“Short Hair”` is input – throw a `WrongBreedException`. That is, create a new class of `Exception` called `WrongBreedException`, which inherits from `Exception`.
- The `message` for this exception should be: `“Only values of: “Long Hair” and “Short Hair” are allowed for the specified species.”`

Do ***NOT*** catch the `WrongBreedException`, just allow the program to crash.
