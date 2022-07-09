import { BookModel } from "./BookModel";

export class CartModel {
 id?: number;
 userId!: number;
 bookId!: number;
 quantity!: number;
}

export class CartList {
 id!: number;
 userId!: number;
 bookId!: number;
 quantity!: number;
 price!: number;
 base64image!: string;
 name!: string;
}

export class GetCart {
 results!: CartList[];
 totalRecords!: number;
}
