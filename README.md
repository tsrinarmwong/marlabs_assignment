# .NET Assignments

This repository contains solutions to assignments using .NET, written in C#. Below are the details of the test cases and their expected results.

## Assignment 1: Find the Unpaired Element

### Description

Given a non-empty array of integers, where each element appears twice except for one, find the unpaired element.

### Test Cases and Expected Results

| Test Case | Input                              | Expected Output            |
|-----------|------------------------------------|-----------------------------|
| array1a   | `[5, 1, 5, 2, 2]`                  | `1`                         |
| array1b   | `[1000000000, 7, 7, 3, 3]`         | `1000000000`                |
| array1c   | `[13, 6, 8, 13, 8, 9, 6]`          | `9`                         |
| array1d   | `[4, 4, 5, 5, 6, 6]`               | `"No unpaired element found"`|
| array1e   | `[4, 0, 4]`                        | `0`                         |

---

## Assignment 2: Maximum Sum of Any Slice

### Description

Given a non-empty array of integers, find the maximum sum of any slice of the array.

### Test Cases and Expected Results

| Test Case | Input                                 | Expected Output |
|-----------|---------------------------------------|------------------|
| array2a   | `[3, 2, -6, 4, 0]`                    | `5`              |
| array2b   | `[-2, -3, -1, -4]`                    | `-1`             |
| array2c   | `[5]`                                  | `5`              |
| array2d   | `[1, 2, 3, 4, 5]`                      | `15`             |
| array2e   | `[5, -1, 5, -1, 5]`                    | `13`             |
| array2f   | `[-1, -2, 4, 5, 6, -3, -2]`            | `15`             |
| array2g   | `[-2, 1, 2, 3, -1]`                    | `6`              |

## How to Run the Project

To run this project locally:

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/DotNetAssignments.git
    ```
2. Navigate to the project directory:
    ```bash
    cd DotNetAssignments/AssignmentSolutions
    ```
3. Build and run the project:
    ```bash
    dotnet run
    ```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
