import ProductInfo from "./ProductInfo";

export default class ShoppingCart {
    productInfos = {};
    productQuantities = {};

    /**
     * 
     * @param {ProductInfo} productInfo 
     * @param {Number} quantity 
     */
    addProduct(productInfo, quantity) {
        console.log("adding", productInfo.id);
        this.productInfos[productInfo.id] = productInfo;
        if (!this.productQuantities[productInfo.id]) {
            this.productQuantities[productInfo.id] = 0;
        }
        this.productQuantities[productInfo.id] += quantity;
    }

    /**
     * 
     * @param {Number} productId 
     * @param {Number} quantity 
     */
    removeProduct(productId, quantity) {
        this.productQuantities[productId] -= quantity;
        if (this.productQuantities[productId] <= 0) {
            delete this.productInfos[productId];
            delete this.productQuantities[productId];
        }
    }

    /**
     * 
     * @returns {Array<{productInfo: ProductInfo, quantity: Number}>}
     */
    getProducts() {
        return Object.keys(this.productInfos).map(productId => ({
            productInfo: this.productInfos[productId],
            quantity: this.productQuantities[productId]
        }));
    }

    /**
     * 
     * @returns {Number}
     */
    getTotalPrice() {
        return Object.keys(this.productInfos).reduce((total, productId) => {
            return total + this.productInfos[productId].price * this.productQuantities[productId];
        }, 0);
    }

    /**
     * 
     * @returns {Number}
     */
    getTax() {
        return Math.ceil(this.getTotalPrice() * 100.0 * 0.06) / 100.0;
    }

    /**
     * 
     * @returns {Number}
     */
    getTotalWithTax() {
        return this.getTotalPrice() + this.getTax();
    }

    clear() {
        this.productInfos = {};
        this.productQuantities = {};
    }

    /**
     * 
     * @returns {ShoppingCart}
     */
    getClone(){
        const clone = new ShoppingCart();
        clone.productInfos = { ...this.productInfos };
        clone.productQuantities = { ...this.productQuantities };
        return clone;
    }
}