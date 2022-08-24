[Point](../../../Point.md) > [Status](../../Status.md) > [On_Status](../On_Status.md) > [On_Off_Status](On_Off_Status.md) > [Motor_On_Off_Status](.)
# Motor_On_Off_Status

**Display name:** Motor On Off Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Motor_On_Off_Status;1

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
