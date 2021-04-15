﻿namespace Fluent_Random_Picker
{
    /// <summary>
    /// The "Out" part of the "Out.Of" syntax.
    /// </summary>
    public static class Out
    {
        /// <summary>
        /// The "Of" part of the "Out.Of" syntax.
        /// </summary>
        /// <returns>An "Of" instance.</returns>
        public static NonGenericOf Of() => NonGenericOf.Create();

        /// <summary>
        /// The "Of&lt;T&gt;" part of the generic "Out.Of" syntax.
        /// </summary>
        /// <typeparam name="T">The type of the values.</typeparam>
        /// <returns>An "Of" instance.</returns>
        public static GenericOf<T> Of<T>() => GenericOf<T>.Create();
    }
}