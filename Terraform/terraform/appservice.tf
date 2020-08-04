terraform {
  required_version = ">= 0.11"
  backend "azurerm" {
    storage_account_name = "$(tfstorage)"
    container_name = "container"
    key = "container.tfstate"
    access_key ="$(storagechave)"
    features{}
    }
  }
  provider "azurerm" {
  features {}
}
resource "azurerm_resource_group" "dev" {
  name     = "$(tfresourcegroup)"
  location = "Central US"
}

resource "azurerm_app_service_plan" "dev" {
  name                = "$(appserviceplan)"
  location            = "${azurerm_resource_group.dev.location}"
  resource_group_name = "${azurerm_resource_group.dev.name}"

  sku {
    tier = "Free"
    size = "F1"
  }
}

resource "azurerm_app_service" "dev" {
  name                = "$(appservice)"
  location            = "${azurerm_resource_group.dev.location}"
  resource_group_name = "${azurerm_resource_group.dev.name}"
  app_service_plan_id = "${azurerm_app_service_plan.dev.id}"

}