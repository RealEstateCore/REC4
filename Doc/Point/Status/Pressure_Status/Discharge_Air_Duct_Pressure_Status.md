[Point](../../Point.md) > [Status](../Status.md) > [Pressure_Status](Pressure_Status.md) > [Discharge_Air_Duct_Pressure_Status](.)
# Discharge_Air_Duct_Pressure_Status

**Display name:** Discharge Air Duct Pressure Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Duct_Pressure_Status;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
