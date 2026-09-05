# 🧮 Calculator-DesktopApplication-WindowsForms

An intuitive and feature-rich **Windows Forms** desktop application built with **C#** and **.NET**, featuring seamless arithmetic capabilities, dynamic theme switching, and robust input validation.

---

## 📸 Application Screenshots

| ☀️ Light Mode | 🌙 Dark Mode |
| :---: | :---: |
| ![Light Mode Screenshot](<img width="480" height="615" alt="Screenshot 2026-09-05 143734" src="https://github.com/user-attachments/assets/1d4ea881-5ba7-4e3d-adad-f027d985b6ab" />) | ![Dark Mode Screenshot](<img width="474" height="624" alt="Screenshot 2026-09-05 143721" src="https://github.com/user-attachments/assets/0f2a1d2e-9d7c-4824-8586-48527a8c75b4" />) |

---

## 🌟 Overview

This project delivers a responsive and user-friendly calculator experience. It is designed to handle common daily mathematical computations while maintaining high code reliability through defensive programming, state-flag management, and user interface customization.

---

## ⚡ Core Operations

* ➕ **Addition (`+`)**: Computes the precise sum of two numbers.
* ➖ **Subtraction (`-`)**: Calculates the mathematical difference between inputs.
* ✖️ **Multiplication (`*`)**: Evaluates the product of numerical values.
* ➗ **Division (`/`)**: Performs floating-point division with built-in zero-checker safeguards.
* 🔢 **Modulus (`%`)**: Computes integer division remainders securely.
* 🧹 **Clear & Edit Tools**:
  * **`AC` (All Clear)**: Fully resets operations, stored memory, flags, and UI components.
  * **`CE` / Backspace (`⌫`)**: Deletes the most recent typed digit or decimal point dynamically.

---

## 💡 Key Concepts Demonstrated

* 🏷️ **Enum-Driven Logic**: Uses explicit `enum enOperations` bound to ASCII characters (`+`, `-`, `*`, `/`, `%`) for safe operation dispatching.
* ⚡ **Event-Driven UI**: Consolidates control handlers (e.g., `btnNumber_Click` and `btnOp_Click`) using dynamic sender casting.
* 🛡️ **Input Validation & Safety**:
  * Enforces a maximum length limit (12 digits) to prevent UI text overflow.
  * Blocks multiple decimal point entries (`.`) in a single sequence.
  * Handles division/modulo by zero gracefully via informative `MessageBox` alerts.
* 🎨 **Dynamic Theme Engine**: Iterates across form controls to switch background and foreground colors dynamically between Light and Dark themes.

---

## 🏗️ Architecture & Design

* **Modular Processing**: Decouples UI interactions from execution logic by encapsulating routines inside helper functions (`CheckSizeAndZeroPlace`, `SetOp`, `GetResult`, `Calc`).
* **State Management**: Controls computation flow using internal boolean state trackers (`PickedOpeation`, `PickedNum1`, `VaildSize`) to avoid invalid operation sequencing.

---

## 🛠️ Technologies Used

* 💻 **Language**: C#
* 🖼️ **GUI Framework**: Windows Forms (WinForms)
* ⚙️ **Runtime**: .NET Framework / .NET Desktop SDK
* 🧰 **IDE**: Microsoft Visual Studio

---


## 🙏 Gratitude

Programming Advices Platform
Dr. Mohammed Abu-Hadhoud

[ https://programmingadvices.com ]

He was not just an instructor!!

He was:

    A mentor
    A coach
    A guide
    A motivator
    A teacher who understands timing

Because the real secret of success in programming is:

    Proper progression
    Correct guidance
    The right timing to learn each concept

And that is exactly what we experienced
