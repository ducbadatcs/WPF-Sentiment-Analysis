using System;
using Microsoft.ML;
using WPF_Sentiment_Analysis;

public class ModelLoader
{
    private static Lazy<PredictionEngine<MLModel1.ModelInput, MLModel1.ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<MLModel1.ModelInput, MLModel1.ModelOutput>>(CreatePredictionEngine);

    public static PredictionEngine<MLModel1.ModelInput, MLModel1.ModelOutput> GetPredictionEngine()
    {
        return PredictionEngine.Value;
    }

    private static PredictionEngine<MLModel1.ModelInput, MLModel1.ModelOutput> CreatePredictionEngine()
    {
        var mlContext = new MLContext();
        var modelPath = "MLModel1.mbconfig";
        ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
        var predEngine = mlContext.Model.CreatePredictionEngine<MLModel1.ModelInput, MLModel1.ModelOutput>(mlModel);
        return predEngine;
    }
}
