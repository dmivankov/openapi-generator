/**
 *
 * Please note:
 * This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit this file manually.
 *
 */

@file:Suppress(
    "ArrayInDataClass",
    "EnumEntryName",
    "RemoveRedundantQualifierName",
    "UnusedImport"
)


package util

import kotlinx.coroutines.CoroutineScope
import kotlin.coroutines.EmptyCoroutineContext

internal actual fun <T> runTest(block: suspend CoroutineScope.() -> T): T = kotlinx.coroutines.runBlocking(EmptyCoroutineContext, block)
