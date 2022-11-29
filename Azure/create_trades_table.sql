CREATE TABLE trades (
    OrderId DECIMAL NOT NULL PRIMARY KEY,
    ImportDate DATETIME, 
    OrderType VARCHAR(20),
    Symbol VARCHAR(50),
    Side VARCHAR(10),
    Price DECIMAL(9,3),
    Qty INT,
    Commission DECIMAL(9,3),
    RealizedPnl DECIMAL(9,3),
    TotalPnl DECIMAL(9,3),
    EquityCurve DECIMAL(9,3)
)