# Algebra calculator API

This is a work-in-progress open-source mathematical calculator designed to solve problems of Linear algebra. For now it only calculates Determinants of square matrices, later on I will add an ability to solve more Algebra and Calculus problems.

## Prerequisites
- ASP.NET
- MathNet.Numerics

## Installation
1) Clone the repository
2) Build the Docker image
3) Host the API

## Usage
Right now the API has configured(very permissive) CORS which allow for non-problematic interactions with Web apps. Right now it only has one **POST** method, which takes in a **JSON** body containing a list of lists of doubles, which is then used by the **CalculateDeterminant** method of the **Calculator** class, to calculate a determinant of any **square** matrix using the [**LU** decomposition](https://en.wikipedia.org/wiki/LU_decomposition) method native to MathNet.Numerics.LinearAlgebra library.

## Note
This is an open-source project aimed at making the lives of students in math-related fields easier. I encourage you to improve/add to this project or use it yourselves.