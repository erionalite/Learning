
var Currency = function(amount){
    this.amount = amount;
}
Currency.prototype.roundTwoDecimals = function(amount){
    return Math.round(amount *100)/100;
}
Currency.prototype.canadianToUS = function ( canadian){
    return roundTwoDecimals(canadian*canadianDollar);
}

Currency.prototype.USToCanadian  = function(us){
    return roundTwoDecimals(us/canadianDollar);
}
exports = Currency; 