package org.openapitools.configuration

import feign.RequestInterceptor
import feign.RequestTemplate

class ApiKeyRequestInterceptor(
    private val location: String,
    private val name: String,
    private val value: String,
) : RequestInterceptor {

    override fun apply(requestTemplate: RequestTemplate) {
        if (location == "header") {
            requestTemplate.header(name, value)
        } else if (location == "query") {
            requestTemplate.query(name, value)
        }
    }
}
