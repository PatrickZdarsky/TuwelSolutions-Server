﻿using TuwelSolution.Models;

namespace TuwelSolution.Services;

public interface ISolutionService
{
    Task<QuizSolution> GetSolution(string identifier, CancellationToken token = default);
    
    Task SaveSolution(QuizSolution solution, CancellationToken token = default);
}