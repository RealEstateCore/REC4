[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Speed_Setpoint_Limit](Speed_Setpoint_Limit.md) > [Min_Speed_Setpoint_Limit](.)
# Min_Speed_Setpoint_Limit

**Display name:** Min Speed Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Speed_Setpoint_Limit;1

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
