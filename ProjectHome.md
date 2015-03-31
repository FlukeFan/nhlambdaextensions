
---


### Note: This project will be superceded in NH3.0 by Query-Over ###
see: http://nhforge.org/blogs/nhibernate/archive/2009/12/17/queryover-in-nh-3-0.aspx


---




A project that provides extension methods for the NHibernate ICriteria interface to allow use of typesafe lambda expressions.

e.g.,
```
    .Add(Expression.Eq("Name", "Smith"))
```
becomes
```
    .Add<Person>(p => p.Name == "Smith")
```


Download the documentation: http://nhlambdaextensions.googlecode.com/files/NhLambdaExtensions.html
