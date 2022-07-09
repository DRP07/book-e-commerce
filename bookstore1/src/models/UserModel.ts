export class AddOrEditUserModel {
	id?: number;
	email!: string;
	firstName!: string;
	lastName!: string;
	roleid!: number;
	name?: string;
	password?: string;
}

export class UpdateProfileModel {
	email!: string;
	firstName!: string;
	lastName!: string;
	newPassword?: string;
	confirmPassword?: string;
}

export default class UserModel {
	id?: number;
	email!: string;
	firstName!: string;
	lastName!: string;
	roleid!: number;
	role?: string;
	password?: string;
}
