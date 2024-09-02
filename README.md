### Explanation of Bad Design

1. **Misuse of Composition:**
   - The `Car` and `Motorcycle` classes use composition with `Engine` and `Tires` objects. While composition is generally a good practice, in this case, it is overused and leads to redundancy. Both `Car` and `Motorcycle` share common components (`Engine` and `Tires`), which should be abstracted out to avoid repetition and potential inconsistencies.
   - A better approach would be to have a `Vehicle` class with `Engine` and `Tires` properties that `Car` and `Motorcycle` inherit from, avoiding duplicated code and making the system more maintainable.

2. **Absence of Factory Pattern:**
   - The creation of `Car` and `Motorcycle` objects is done manually in the `Main` method. This process is repetitive and error-prone, especially as the complexity of the objects increases (e.g., more components, different configurations).
   - The lack of a Factory pattern makes it harder to manage object creation, especially if the creation logic becomes more complex or needs to change in the future.
