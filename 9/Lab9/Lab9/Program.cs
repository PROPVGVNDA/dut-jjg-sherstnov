﻿//8-12

/*
 * 1.3 Створити абстрактний клас Triangle з абстрактними властивостями і методами.
 * Мінімальний набір абстрактних властивостей: колір фігури (читання і запис), 
 * довжина однієї сторони (читання і запис), довжина іншої сторони (читання і запис), 
 * кут між цими сторонами (читання і запис), ім’я об’єкту (тільки читання). 
 * Мінімальний набір абстрактних методів: метод обрахунку площі, метод обрахунку периметру.
 * 
 * 2 Створити клас Picture. Поля колекція (List<абстрактний клас із Завдання 1.х>).
 * Конструктори: без параметрів, з одним параметром (довжина колекції).
 * Методи: додавання нової фігури, видалення існуючої фігури (за ім’ям, за типом, якщо фігура перевищує задану площу)
 * Властивості: кількість елементів в колекції
 * Індексатор: отримати елемент з колекції за індексом
*/

using Lab9;

Console.OutputEncoding = System.Text.Encoding.Unicode; // відображення літери і
