[Point](../../Point.md) > [Status](../Status.md) > [System_Status](#)
# System_Status

**Display name:** System Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:System_Status;1

---


## Child interfaces
* [Heat_Exchanger_System_Enable_Status](Heat_Exchanger_System_Enable_Status.md)
* [Emergency_Air_Flow_System_Status](Emergency_Air_Flow_System_Status.md)
* [System_Shutdown_Status](System_Shutdown_Status.md)
* [Emergency_Power_Off_System_Status](Emergency_Power_Off_System_Status/Emergency_Power_Off_System_Status.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
