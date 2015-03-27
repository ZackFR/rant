﻿namespace Rant.Vocabulary
{
    /// <summary>
    /// Represents a Rant dictionary.
    /// </summary>
    public interface IRantDictionary
    {
        /// <summary>
        /// Queries the dictionary according to the specified criteria and returns a random match.
        /// </summary>
        /// <param name="rng">The random number generator to randomize the match with.</param>
        /// <param name="query">The search criteria to use.</param>
        /// <param name="syncState">The state object to use for carrier synchronization.</param>
        /// <returns></returns>
        string Query(RNG rng, Query query, QueryState syncState);

        /// <summary>
        /// Adds a new RantDictionaryTable object to the collection.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="mergeBehavior">The merging strategy to employ.</param>
        void AddTable(RantDictionaryTable table, TableMergeBehavior mergeBehavior = TableMergeBehavior.Naive);
    }
}