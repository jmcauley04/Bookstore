import ProductInfo from "../models/ProductInfo";
import ProductCategory from "../models/ProductCategory";

class ProductLookupService {
  constructor() {
    this.products = [
      new ProductInfo({
        upc: '123',
        id: 1,
        name: "Apple",
        description: "A red apple",
        price: 1.99,
        category: 5,
        stock: 10,
        stock_date: "2024-10-20",
        last_sold: "2025-01-15",
      }),

      new ProductInfo({
        upc: '456',
        id: 2,
        name: "Banana",
        description: "A yellow banana",
        price: 0.99,
        category: 5,
        stock: 20,
        stock_date: "2024-09-20",
        last_sold: "2025-01-20",
      }),
      new ProductInfo({
        upc: '789',
        id: 3,
        name: "Cherry",
        description: "A red cherry",
        price: 2.99,
        category: 5,
        stock: 12,
        stock_date: "2024-11-20",
        last_sold: "2025-01-03",
      }),
    ];
  }

  /**
   * 
   * @param {string} upc 
   * @returns {Promise<ProductInfo>}
   */
  getProductByUPC(upc) {
    return new Promise((resolve) => {
      setTimeout(() => {
        const product = this.products.find((p) => p.upc === upc);
        resolve(product);
      }, 1000);
    });
  }

  /**
   * 
   * @param {number} id 
   * @returns {Promise<ProductInfo>}
   */
  getProductByID(id) {
    return new Promise((resolve) => {
      setTimeout(() => {
        const product = this.products.find((p) => p.id === id);
        resolve(product);
      }, 1000);
    });
  }
}

export default ProductLookupService;
