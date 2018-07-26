var Currency = require('currency');
var currencyObject = new Currency(0.93)
console.log('50 Canadian dollas equal this amount of us dollars');
console.log(currencyObject.canadianToUS(50));
console.log('30 US dollars equals this amount of Canadian dollars');
console.log(currencyObject.USToCanadian(30));