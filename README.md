# Unexpected Side Effects with Mutable Variables in F# Function

This example demonstrates a common issue in F# related to mutable variables and side effects within functions. The function `add` uses mutable variables and modifies its input parameters directly, leading to unexpected behavior and results that depend on the order of operations. This can make debugging and understanding the program's logic difficult.

The solution shows how to avoid side effects by using immutable values and returning new values instead of modifying input parameters directly.  The corrected version is more predictable and easier to reason about.