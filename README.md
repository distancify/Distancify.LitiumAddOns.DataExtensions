# Distancify.LitiumAddOns.DataExtensions

## IndexedTextValue

This extension provides a simple way to index and query entities based on field text values. The
default text field search using the DataService is slow and unindexed. By indexing key fields
you can query entities faster. This is useful for finding customers based on for example e-mail
or name.

**Note that the indexed text value can not be longer than 250 characters.**

### Usage

Start by creating a class implementing `IIndexedTextField`:

```csharp
using Distancify.LitiumAddOns.DataExtensions;
using Litium.FieldFramework;

namespace RevolutionRace.DataExtensions
{
    public class EmailIndexedTextField : IIndexedTextField
    {
        public string FieldDefinitionId => SystemFieldDefinitionConstants.Email;
    }
}
```

This tells the data processor to copy the text value of the specified field to the index.

Next, start querying:

```csharp
using (var query = IoC.Resolve<DataService>.CreateQuery<Person>())
{
    return query.Filter(f => f.IndexedTextField(SystemFieldDefinitionConstants.Email, email));
}
```

### Indexing historical values

Once a field is set to be indexed, only changes for that field will be indexed, no historical
indexing takes place automatically. This can however be easily set by a SQL query (assuming the
example above):

```sql
UPDATE Customers.PersonFieldData SET IndexedTextValue = TextValue WHERE FieldDefinitionId = '_email'
```