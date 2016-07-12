# IronyCameraDsl
Example dsl parser using Irony project.

A parser for a simple camera dsl using Irony following [this tutorial](http://www.codeproject.com/Articles/26975/Writing-Your-First-Domain-Specific-Language-Part).

The dsl looks like this:

```
Set camera size: 400 by 300 pixels.
Set camera position: 100, 100.
Move 200 pixels right.
Move 100 pixels up.
Move 250 pixels left.
Move 50 pixels down.
```

See https://irony.codeplex.com/

Notes:

The original tutorial seems to have been written for an early version of Irony from around 2013. My project and solution uses version 0.91 of Irony from nuget. As such there are a few differences between the code and the tutorial.

1. You need to set the case sensitivity flag in the grammar constructor.
2. Use ToTerm() instead of Symbol()
3. Use MarkPunctuation instead of RegisterPunctuation
4. I created a Parser instead of a LanguageCompiler.
5. The AstNode objects all seems to be null but the ParseTree and its nodes seem to be ok.

