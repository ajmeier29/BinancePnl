# BinancePnl

## Description
.Net 6 WebAPI project that will perform all calls involved in gathering my Binance Pnl data.

## Setup

## Design

### Azure
- Hosted on Azure using these resources
    - Azure WebApp
    - Azure SQL Server
    - Azure SQL DB

### Binance API
Binance API is is python library used for interfacing with your account. I have leveraged this API in python and created a microservice in Azure that this webapi can call to collect the appropriate data from my account.