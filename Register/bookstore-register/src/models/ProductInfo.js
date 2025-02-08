export default class ProductInfo {
    constructor({
        upc, 
        id,
        name, 
        price, 
        description, 
        category, 
        stock, 
        stock_date, 
        last_sold
    } = {}) {
        this.upc = upc;
        this.id = id; 
        this.name = name;
        this.price = price;
        this.description = description;
        this.category = category;
        this.stock = stock;
        this.stock_date = stock_date;
        this.last_sold = last_sold;
    }
  
    toString() {
        return `${this.name} ${this.price} ${this.description}`;
    }
}