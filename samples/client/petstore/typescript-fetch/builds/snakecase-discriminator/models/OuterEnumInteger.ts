/* tslint:disable */
/* eslint-disable */
/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


/**
 * 
 * @export
 */
export const OuterEnumInteger = {
    NUMBER_0: 0,
    NUMBER_1: 1,
    NUMBER_2: 2
} as const;
export type OuterEnumInteger = typeof OuterEnumInteger[keyof typeof OuterEnumInteger];


export function OuterEnumIntegerFromJSON(json: any): OuterEnumInteger {
    return OuterEnumIntegerFromJSONTyped(json, false);
}

export function OuterEnumIntegerFromJSONTyped(json: any, ignoreDiscriminator: boolean): OuterEnumInteger {
    return json as OuterEnumInteger;
}

export function OuterEnumIntegerToJSON(value?: OuterEnumInteger | null): any {
    return value as any;
}

