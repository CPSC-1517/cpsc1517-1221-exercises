# Exercise 5: Train Watch - Query Paging, Page to Page data transfer, CRUD page. 

> This is the **fourth** in a series of exercises where you will be building a website to manage information on trains. **Train Watch** is a community site for train lovers who want to keep up-to-date on trains across North America. They want to maintain a database of Engines and RailCars.
>
> **This set is cumulative**; future exercises in this series will build upon previous exercises.

## Overview

A key aspect of the site is to allow users to search the database to find information on various rail cars. This site will allow the user to maintain records on the database. Your task in this assignment is to provide that functionality.

Use the demos presented in class as a guide to implementing this exercise.

### Implementing of paging for a tabular query display

Modify the `Query.cshtml`/`Query.cshtml.cs` Razor Page. The tabular display of RollingStock from Exercise 5 will implement a form of paging. Using the Paginator class demonstrated in your lessons, alter the RollingStock display so that only 10 rows are shown at a time.

You will need to alter your service query method to accomondate the paginator.

### Page to Page Data transfer

Alter the Rolling Stock display line to contain a link which will transfer control to another Razor Page called `CRUDPage.cshtml`. The data to transfer will be the ReportingMark value.

Add a button, called `New`, to the `Query.cshtml` page which will transfer contol to the `CRUDPage.cshtml` page. No data will be transfered with this redirection.

### CRUDPage

Create a Razor Page called `CRUDPage.cshtml`. This page will be used to maintain the RollingStock database table. Maintenance will consist of a) adding new RollingStock; b) updating existing RollingStock; and c) delete a RollingStock. Create a form that will display all fields of the record. Use a select control for the RailCartype. Use a checkbox control for the InService. The ReportingMark control will be made unchangable if the RollingStock record exists (Update/Delete) but will be changable if adding a new record. The Delete button must have a confirmation message attached to the button. Add a button to return to the `Query` page.

Add appropriate service methods to your RollingStock services to a) obtain a specific RollingStock record (see supplied query), b) add a new record to the RollingStock table, c) update an existing record on the RollingStock table and d) remove an existing record from active service on the RollingStock table by setting the In-service to false.

Query: RollingStockServices.GetByID

```
 RollingStock info = _context.RollingStocks
                             .Where(x => x.ReportingMark.Equals(searcharg))
                             .FirstOrDefault();
```


#### CRUDPage.cshtml.cs OnGet

The OnGet will call the `.GetByID` query if the routing parameter contains data.



To ensure that your web application works, build and run your project.
