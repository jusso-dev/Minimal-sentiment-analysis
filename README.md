# Minimal-sentiment-analysis
Minimal .NET 6 API project that performs sentiment analysis via a WEBAPI in less than 40 lines of code!

<img src="minimal sentiment analysis.png" />

## What is this?

This project demostrates how to train and consume a ML.NET Binary Classification ML model using less than 40 lines of code thanks to .NET 6 minimal APIs.

## Getting started

``` 
git clone https://github.com/jusso-dev/Minimal-sentiment-analysis 

cd Minimal-sentiment-analysis

dotnet run Minimal-sentiment-analysis
```

## Model location

When the solution is built, the Minimal_sentiment_analysis_Consumer project will copy the "Minimal-sentiment-analysis.zip" outputted file to the Minimal-sentiment-analysis bin folder. This can be changed in /Minimal_sentiment_analysis_Consumer/Minimal-sentiment-analysis.consumption.cs

## Training data

The root of the project contains the training data "IMDB Dataset.csv" which is a Kaggle IMDB movie review dataset - credit - https://www.kaggle.com/lakshmi25npathi/imdb-dataset-of-50k-movie-reviews/version/1

## Training on more/different data

Simply open Visual Studio 2019 with the ML.NET extension installed, open the Minimal-sentiment-analysis.mbconfig under the "Minimal_sentiment_analysis_Consumer" project by double-clicking, follow the prompts for a simple classification task, update location of training file relevant to your machine, and run!