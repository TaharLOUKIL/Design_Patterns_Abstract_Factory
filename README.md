# Design_Patterns_Abstract_Factory
C# Design Patterns | Abstract Factory Example

The application needs to support the SQL server and oleDB databases but we don't want the entire application to have to deal with
the different kinds of commands and connection objects that are used for those databases.

We, actually, don't even want our data layer to support that. Either we simply want the factory pattern to be able to give us 
the right database class and the rest of the app doesn't have to know anything about the underlying technology of the
database. So we get a nice separation of concerns that way.

We have an abstract class called Database has two properties :
1. a command property
2. a connection property

We have two classes that inherit from Database :
1. SqlServerDatabase : implements command and connection.
2. OleDBDatabase     : implements command and connection.

In both cases we have corresponding private fields.
