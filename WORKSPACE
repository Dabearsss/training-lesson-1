git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet.git",
    commit = "aca4b3703caea5170b925664935b0f503c65b3cc",
)

load(
    "@io_bazel_rules_dotnet//dotnet:csharp.bzl",
    "csharp_repositories",
    "nuget_package",
)

csharp_repositories(use_local_mono = True)

nuget_package(
  name = "some_name",
  package = "Some.Package",
  version = "0.1.2",
)
