[Point](../../Point.md) > [Status](../Status.md) > [System_Status](System_Status.md) > [Heat_Exchanger_System_Enable_Status](.)
# Heat_Exchanger_System_Enable_Status

**Display name:** Heat Exchanger System Enable Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heat_Exchanger_System_Enable_Status;1

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
