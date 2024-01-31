/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Provides hosting configuration for Org.OpenAPITools
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyNullableJsonConverter());
            _jsonOptions.Converters.Add(new ActivityJsonConverter());
            _jsonOptions.Converters.Add(new ActivityOutputElementRepresentationJsonConverter());
            _jsonOptions.Converters.Add(new AdditionalPropertiesClassJsonConverter());
            _jsonOptions.Converters.Add(new AnimalJsonConverter());
            _jsonOptions.Converters.Add(new ApiResponseJsonConverter());
            _jsonOptions.Converters.Add(new AppleJsonConverter());
            _jsonOptions.Converters.Add(new AppleReqJsonConverter());
            _jsonOptions.Converters.Add(new ArrayOfArrayOfNumberOnlyJsonConverter());
            _jsonOptions.Converters.Add(new ArrayOfNumberOnlyJsonConverter());
            _jsonOptions.Converters.Add(new ArrayTestJsonConverter());
            _jsonOptions.Converters.Add(new BananaJsonConverter());
            _jsonOptions.Converters.Add(new BananaReqJsonConverter());
            _jsonOptions.Converters.Add(new BasquePigJsonConverter());
            _jsonOptions.Converters.Add(new CapitalizationJsonConverter());
            _jsonOptions.Converters.Add(new CatJsonConverter());
            _jsonOptions.Converters.Add(new CategoryJsonConverter());
            _jsonOptions.Converters.Add(new ChildCatJsonConverter());
            _jsonOptions.Converters.Add(new ClassModelJsonConverter());
            _jsonOptions.Converters.Add(new ComplexQuadrilateralJsonConverter());
            _jsonOptions.Converters.Add(new DanishPigJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyClassJsonConverter());
            _jsonOptions.Converters.Add(new DeprecatedObjectJsonConverter());
            _jsonOptions.Converters.Add(new DogJsonConverter());
            _jsonOptions.Converters.Add(new DrawingJsonConverter());
            _jsonOptions.Converters.Add(new EnumArraysJsonConverter());
            _jsonOptions.Converters.Add(new EnumClassJsonConverter());
            _jsonOptions.Converters.Add(new EnumClassNullableJsonConverter());
            _jsonOptions.Converters.Add(new EnumTestJsonConverter());
            _jsonOptions.Converters.Add(new EquilateralTriangleJsonConverter());
            _jsonOptions.Converters.Add(new FileJsonConverter());
            _jsonOptions.Converters.Add(new FileSchemaTestClassJsonConverter());
            _jsonOptions.Converters.Add(new FooJsonConverter());
            _jsonOptions.Converters.Add(new FooGetDefaultResponseJsonConverter());
            _jsonOptions.Converters.Add(new FormatTestJsonConverter());
            _jsonOptions.Converters.Add(new FruitJsonConverter());
            _jsonOptions.Converters.Add(new FruitReqJsonConverter());
            _jsonOptions.Converters.Add(new GmFruitJsonConverter());
            _jsonOptions.Converters.Add(new GrandparentAnimalJsonConverter());
            _jsonOptions.Converters.Add(new HasOnlyReadOnlyJsonConverter());
            _jsonOptions.Converters.Add(new HealthCheckResultJsonConverter());
            _jsonOptions.Converters.Add(new IsoscelesTriangleJsonConverter());
            _jsonOptions.Converters.Add(new ListJsonConverter());
            _jsonOptions.Converters.Add(new LiteralStringClassJsonConverter());
            _jsonOptions.Converters.Add(new MammalJsonConverter());
            _jsonOptions.Converters.Add(new MapTestJsonConverter());
            _jsonOptions.Converters.Add(new MixedPropertiesAndAdditionalPropertiesClassJsonConverter());
            _jsonOptions.Converters.Add(new Model200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new ModelClientJsonConverter());
            _jsonOptions.Converters.Add(new NameJsonConverter());
            _jsonOptions.Converters.Add(new NotificationtestGetElementsV1ResponseMPayloadJsonConverter());
            _jsonOptions.Converters.Add(new NullableClassJsonConverter());
            _jsonOptions.Converters.Add(new NullableGuidClassJsonConverter());
            _jsonOptions.Converters.Add(new NullableShapeJsonConverter());
            _jsonOptions.Converters.Add(new NumberOnlyJsonConverter());
            _jsonOptions.Converters.Add(new ObjectWithDeprecatedFieldsJsonConverter());
            _jsonOptions.Converters.Add(new OneOfStringJsonConverter());
            _jsonOptions.Converters.Add(new OrderJsonConverter());
            _jsonOptions.Converters.Add(new OuterCompositeJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumNullableJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumDefaultValueJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumDefaultValueNullableJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumIntegerJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumIntegerNullableJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumIntegerDefaultValueJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumIntegerDefaultValueNullableJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumTestJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumTestNullableJsonConverter());
            _jsonOptions.Converters.Add(new ParentPetJsonConverter());
            _jsonOptions.Converters.Add(new PetJsonConverter());
            _jsonOptions.Converters.Add(new PigJsonConverter());
            _jsonOptions.Converters.Add(new PolymorphicPropertyJsonConverter());
            _jsonOptions.Converters.Add(new QuadrilateralJsonConverter());
            _jsonOptions.Converters.Add(new QuadrilateralInterfaceJsonConverter());
            _jsonOptions.Converters.Add(new ReadOnlyFirstJsonConverter());
            _jsonOptions.Converters.Add(new RequiredClassJsonConverter());
            _jsonOptions.Converters.Add(new ReturnJsonConverter());
            _jsonOptions.Converters.Add(new RolesReportsHashJsonConverter());
            _jsonOptions.Converters.Add(new RolesReportsHashRoleJsonConverter());
            _jsonOptions.Converters.Add(new ScaleneTriangleJsonConverter());
            _jsonOptions.Converters.Add(new ShapeJsonConverter());
            _jsonOptions.Converters.Add(new ShapeInterfaceJsonConverter());
            _jsonOptions.Converters.Add(new ShapeOrNullJsonConverter());
            _jsonOptions.Converters.Add(new SimpleQuadrilateralJsonConverter());
            _jsonOptions.Converters.Add(new SpecialModelNameJsonConverter());
            _jsonOptions.Converters.Add(new TagJsonConverter());
            _jsonOptions.Converters.Add(new TestCollectionEndingWithWordListJsonConverter());
            _jsonOptions.Converters.Add(new TestCollectionEndingWithWordListObjectJsonConverter());
            _jsonOptions.Converters.Add(new TestInlineFreeformAdditionalPropertiesRequestJsonConverter());
            _jsonOptions.Converters.Add(new TriangleJsonConverter());
            _jsonOptions.Converters.Add(new TriangleInterfaceJsonConverter());
            _jsonOptions.Converters.Add(new UserJsonConverter());
            _jsonOptions.Converters.Add(new WhaleJsonConverter());
            _jsonOptions.Converters.Add(new ZebraJsonConverter());
            _jsonOptions.Converters.Add(new ZeroBasedEnumJsonConverter());
            _jsonOptions.Converters.Add(new ZeroBasedEnumNullableJsonConverter());
            _jsonOptions.Converters.Add(new ZeroBasedEnumClassJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<AnotherFakeApiEvents>();
            _services.AddTransient<IAnotherFakeApi, AnotherFakeApi>();
            _services.AddSingleton<DefaultApiEvents>();
            _services.AddTransient<IDefaultApi, DefaultApi>();
            _services.AddSingleton<FakeApiEvents>();
            _services.AddTransient<IFakeApi, FakeApi>();
            _services.AddSingleton<FakeClassnameTags123ApiEvents>();
            _services.AddTransient<IFakeClassnameTags123Api, FakeClassnameTags123Api>();
            _services.AddSingleton<PetApiEvents>();
            _services.AddTransient<IPetApi, PetApi>();
            _services.AddSingleton<StoreApiEvents>();
            _services.AddTransient<IStoreApi, StoreApi>();
            _services.AddSingleton<UserApiEvents>();
            _services.AddTransient<IUserApi, UserApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IAnotherFakeApi, AnotherFakeApi>(client));
            builders.Add(_services.AddHttpClient<IDefaultApi, DefaultApi>(client));
            builders.Add(_services.AddHttpClient<IFakeApi, FakeApi>(client));
            builders.Add(_services.AddHttpClient<IFakeClassnameTags123Api, FakeClassnameTags123Api>(client));
            builders.Add(_services.AddHttpClient<IPetApi, PetApi>(client));
            builders.Add(_services.AddHttpClient<IStoreApi, StoreApi>(client));
            builders.Add(_services.AddHttpClient<IUserApi, UserApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
