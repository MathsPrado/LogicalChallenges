# 📈 121. Best Time to Buy and Sell Stock

![Difficulty: Easy](https://img.shields.io/badge/Difficulty-Easy-brightgreen)
![Topics: Array, Dynamic Programming](https://img.shields.io/badge/Topics-Array%20%7C%20DP-blue)

## 📝 Problem Description

You are given an array `prices` where `prices[i]` is the price of a given stock on the $i^{th}$ day.

You want to maximize your profit by choosing a **single day** to buy one stock and choosing a **different day in the future** to sell that stock.

### 📋 Rules:
* You must buy before you sell.
* If you cannot achieve any profit, return `0`.

---

## 🚀 Examples

| Input | Output | Explanation |
| :--- | :--- | :--- |
| `prices = [7,1,5,3,6,4]` | `5` | Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5. |
| `prices = [7,6,4,3,1]` | `0` | No transactions are done and the max profit = 0. |

---

## ⚙️ Constraints

* $1 \le \text{prices.length} \le 10^5$
* $0 \le \text{prices[i]} \le 10^4$
