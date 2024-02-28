using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Reinsertions;


public class Elitism : ReinsertionBase
{
    protected int eliteSize = 0;
    public Elitism(int eliteSize) : base(false, false)
    {
        this.eliteSize = eliteSize;
    }
    
    protected override IList<IChromosome> PerformSelectChromosomes(IPopulation population, IList<IChromosome> offspring, IList<IChromosome> parents)
    {
        // YOUR CODE HERE

        //população anterior ordenadapor fitness
        var old_population = population.CurrentGeneration.Chromosomes.OrderByDescending(p => p.Fitness).ToList(); 

        //seleciona os melhores carros (numero de carros = eliteSize)
        int i = 0;
        for(i = 0; i < eliteSize; i++)
        {
            offspring[i] = old_population[i];
        }

        return offspring;
    }
    
}
