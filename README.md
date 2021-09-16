# kmart.coding.challenge

longest increasing subsequence

[![.Net Framework](https://img.shields.io/badge/DotNet-5.0-blue.svg?style=plastic)](https://www.microsoft.com/net/download/dotnet-core/5.0) | ![GitHub language count](https://img.shields.io/github/languages/count/ajeetx/41c32d06-1533-11ec-82a8-0242ac130003.svg) | ![GitHub top language](https://img.shields.io/github/languages/top/ajeetx/41c32d06-1533-11ec-82a8-0242ac130003.svg) |![GitHub repo size in bytes](https://img.shields.io/github/repo-size/ajeetx/41c32d06-1533-11ec-82a8-0242ac130003.svg) 
| --- | ---          | ---            |  --- |

---------------------------------------

## Repository structure
 
The repository consists of projects as below:


| # |project name | project type | folder location| Project Platform |
| ---| ---  | ---           | ---          | --- |
| 1 | Kmart.Code.Challenge | .Net5 class library  |  **Kmart.Code.Challenge**  | [![.Net Framework](https://img.shields.io/badge/DotNet-5.0-blue.svg?style=plastic)](https://www.microsoft.com/net/download/dotnet-core/5.0)|
| 2 | Kmart.Code.Challenge.Tests | Test for .Net5 class library |  **Kmart.Code.Challenge.Tests** | [![.Net Framework](https://img.shields.io/badge/DotNet-5.0-blue.svg?style=plastic)](https://www.microsoft.com/net/download/dotnet-core/5.0)| 


>   Since my PC does not support docker [as of now :( ], the github actions workflow runs the dotnet sdk.

 I have previously implemented [docker sample](https://github.com/dotnetcore5/dotnet2-microservices-docker-swagger) through `docker-compose`

# Solution synopsis:
-   The repository name is a [UUID](https://www.uuidgenerator.net/version4).
-   Followed SOLID principle to implement the business requirement.
-   Integrated linting to standardize quality definitions and compliance through rules
-   Establised a robust design by ensuring full test code-coverge.
-   Setup Continuous Integration through [GitHub Actions](https://docs.github.com/en/free-pro-team@latest/actions).

# Coding Test Detail

## Objective:
This coding test is designed to assess following software development skills:
-	Transform business problems to automated tests and develop solution (TDD)
-	Simple Design (Passes tests, reveals intent, DRY, small)
-	Continuous integration and deployment

## Problem
Develop a function that takes one string input of any number of integers separated by single whitespace. The function then outputs the longest increasing subsequence (increased by any number) present in that sequence. If more than 1 sequence exists with the longest length, output the earliest one. You may develop supporting functions as many as you find reasonable.

