export function toMoney(value) {
    return value.toLocaleString('en-US', {style: 'currency', currency: 'USD'});
}