
# WagTool

A programme for a company handling industrial scales. It is used to take
measurements of scales, time and correctness of measurements taken. Still in progress

# Functionality

- Counting of start time, end time and duration of measurement (currently with dummy weight data, due to the lack of written linking logic to the weight)
- Material selection (ultimately configurable from file)
- Control of programme user actions
- Linking to an SQL database and recording after each measurement
- Report generation to .csv file

## In future: 
- Reading values from the scale from the serial COM port
- Configurable connection parameters
- Refactoring


## Screenshots
Main screen after finished measurement
![Main screen after finished measurement](https://i.imgur.com/Bmtz1kj.png)

Database table view

![Database table view](https://i.imgur.com/LRcuz7Y.png)


## Editing database connection config
Data source can be changed via DATA_SOURCE field in IOController class.

```cs
public static readonly string DATA_SOURCE = "your_mssql_server_name";
```

Database name can be changed via INITIAL_CATALOG field

```cs
public static readonly string INITIAL_CATALOG = "your_db_name";
```

Every other property related to SQL connection can be edited via connectionString field.
