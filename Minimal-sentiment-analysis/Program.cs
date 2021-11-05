using Minimal_sentiment_analysis_Consumer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/predict", (string phrase) =>
{
    if(string.IsNullOrEmpty(phrase)) 
    {
        return Results.BadRequest("URL parameter 'phrase' expected.");
    }

    Minimal_sentiment_analysis.ModelInput sentiment = new Minimal_sentiment_analysis.ModelInput()
    {
        Review = phrase
    };

    var predictionResult = Minimal_sentiment_analysis.Predict(sentiment);

    return Results.Ok(predictionResult);
})
.WithName("GetSentiment");

app.Run();