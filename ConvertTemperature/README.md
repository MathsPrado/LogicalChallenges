# 2469. Convert the Temperature Leetcode

## 🏆 Difficulty: Easy
## 🏷️ Topics: Math, Array

## 📝 Problem Description

You are given a **non-negative** floating-point number (rounded to two decimal places), denoted as `celsius`, that represents the temperature in **Celsius**.

You should convert Celsius into **Kelvin** and **Fahrenheit** and return it as an array `ans = [kelvin, fahrenheit]`.

Return the array `ans`. Answers within $10^{-5}$ of the actual answer will be accepted.

Note that the conversion formulas are:

$$\text{Kelvin} = \text{Celsius} + 273.15$$
$$\text{Fahrenheit} = \text{Celsius} \times 1.80 + 32.00$$

## 💡 Examples

### Example 1:

**Input:** `celsius = 36.50`
**Output:** `[309.65000, 97.70000]`
**Explanation:**
* Temperature at 36.50 Celsius converted to Kelvin is $36.50 + 273.15 = 309.65$.
* Converted to Fahrenheit is $36.50 \times 1.80 + 32.00 = 97.70$.

### Example 2:

**Input:** `celsius = 122.11`
**Output:** `[395.26000, 251.79800]`
**Explanation:**
* Temperature at 122.11 Celsius converted to Kelvin is $122.11 + 273.15 = 395.26$.
* Converted to Fahrenheit is $122.11 \times 1.80 + 32.00 = 251.798$.

## ⚙️ Constraints

* $0 \le \text{celsius} \le 1000$
