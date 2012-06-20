## What is this? ##

This is a demonstrator of cluster pattern for NO MVC and Entity Framework.  It shows a 1:1 polymorphic property across clusters (ie referencing an interface)

## Entities ##

- Payments cluster
  - Payment
  - IPayee
- Customers cluster
  - Customer (implements IPayee)
- Employers cluster
  - Employer (implements IPayee)

## Of Note ##

- The (framework-provided) ObjectFinder is used to polymorphically look up the related IBusinessEngagement from the BusinessEngagementSummary.

- this example does not provide a FK safety; to do so would require introducing a "summary" table (see the nomvc-poly1 example for how this looks for a 1:m collection).
