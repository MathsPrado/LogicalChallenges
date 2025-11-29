# 20. Valid Parentheses

![Difficulty: Easy](https://img.shields.io/badge/Difficulty-Easy-brightgreen)

## 📌 Problem Description

Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['`, and `']'`, determine if the input string is valid.

An input string is valid if:
- Open brackets must be closed by the same type of brackets.
- Open brackets must be closed in the correct order.
- Every close bracket has a corresponding open bracket of the same type.

---

## ✅ Examples

**Example 1:**  
- **Input:** `s = "()"`
- **Output:** `true`

**Example 2:**  
- **Input:** `s = "()[]{}"`
- **Output:** `true`

**Example 3:**  
- **Input:** `s = "(]"`
- **Output:** `false`

**Example 4:**  
- **Input:** `s = "([])"`
- **Output:** `true`

**Example 5:**  
- **Input:** `s = "([)]"`
- **Output:** `false`

---

## 📏 Constraints

- `1 <= s.length <= 10^4`
- `s` consists of parentheses only: `'()[]{}'`

---

## 💡 Hints

- Use a **stack** to keep track of opening brackets.
- For every closing bracket, verify it matches the most recent unmatched opening bracket.
- At the end, all brackets should be matched (stack must be empty).

---

## 🧠 Approach

The key idea is to process each character sequentially:
1. When encountering an **opening bracket** (`(`, `{`, `[`), push it onto the stack.
2. When encountering a **closing bracket** (`)`, `}`, `]`):
   - Check if the stack is not empty and the top element is the corresponding opening bracket.
   - If yes, pop from the stack.
   - Otherwise, return `false`.
3. After processing all characters, return `true` only if the stack is empty.

This ensures correct pairing, type matching, and nesting order.

---

## ⏱️ Time Complexity: `O(n)`  
## 🧠 Space Complexity: `O(n)` *(stack storage in worst case)*

---

## 🏷️ Topics

`#Stack` `#String` `#DataStructures` `#Algorithms`

