# act-according-to-the-key-pressed-on-the-keyboard

* When you press 'A' on the keyboard: *Print all numbers from 1 to 100 to the console, in ascending order.*
* When you press 'S' on the keyboard: *Print all numbers from 1 to 100 to the console in descending order.*
* When you press 'D' on the keyboard: *Calculate the sum of numbers from 1 to n.*
  1. When you press 'Z' on the keyboard: *Implementation using a for-loop.*
  2. When you press 'X' on the keyboard: *Implementation using a while-loop.*
  3. When you press 'C' on the keyboard: *Implementation using LINQ.*
  4. When you press 'Esc' on the keyboard: *Exit the program.*
* When you press 'Esc' on the keyboard: *Exit the program.*

** Console(Terminal) Window Settings **

We will run the application inside VS Code's integrated terminal. In this we need to change the ``"console"`` settings. First, let's open the ``launch.json`` file in the ``.vscode`` folder in the project. Change the line ``"console": "internalConsole",`` found here to ``"console": "integratedTerminal",`` . Your code should be as follows.

```
{
    "configurations": [
        {
          //"console": "internalConsole",
            "console": "integratedTerminal",
        }
    ]
}
```

**RUN**

Run the ``dotnet run`` command from the terminal.
